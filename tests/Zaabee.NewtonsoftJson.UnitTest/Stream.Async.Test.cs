using System;
using System.IO;
using System.Threading.Tasks;
using TestModels;
using Xunit;
using Zaabee.Extensions;

namespace Zaabee.NewtonsoftJson.UnitTest
{
    public partial class NewtonsoftJsonUnitTest
    {
        [Fact]
        public async Task StreamAsyncTest()
        {
            TestModel nullModel = null;
            Stream nullMs = null;
            await nullModel.PackToAsync(nullMs);
            await nullMs.PackByAsync(nullModel);
            Assert.Null(nullModel);

            var testModel = TestModelFactory.Create();
            var stream0 = new FileStream(".\\StreamTest0", FileMode.Create);
            await testModel.PackToAsync(stream0);
            var stream1 = new FileStream(".\\StreamTest1", FileMode.Create);
            await stream1.PackByAsync(testModel);

            var unPackResult0 = await stream0.FromStreamAsync<TestModel>();
            var unPackResult1 = await stream1.FromStreamAsync<TestModel>();

            Assert.Equal(
                Tuple.Create(testModel.Id, testModel.Age, testModel.CreateTime, testModel.Name, testModel.Gender),
                Tuple.Create(unPackResult0.Id, unPackResult0.Age, unPackResult0.CreateTime, unPackResult0.Name,
                    unPackResult0.Gender));
            Assert.Equal(
                Tuple.Create(testModel.Id, testModel.Age, testModel.CreateTime, testModel.Name, testModel.Gender),
                Tuple.Create(unPackResult1.Id, unPackResult1.Age, unPackResult1.CreateTime, unPackResult1.Name,
                    unPackResult1.Gender));
        }
    }
}