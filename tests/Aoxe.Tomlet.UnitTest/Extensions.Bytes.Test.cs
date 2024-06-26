namespace Aoxe.Tomlet.UnitTest;

public partial class ExtensionsTest
{
    [Fact]
    public void GenericTypeBytesTest()
    {
        var testModel = TestModelHelper.Create();
        var bytes = testModel.ToBytes();
        var result = bytes.FromBytes<TestModel>()!;

        Assert.Equal(testModel, result);
    }

    [Fact]
    public void GenericTypeBytesNullTest()
    {
        TestModel? nullModel = null;
        byte[]? nullBytes = null;
        Assert.Null(nullModel.ToBytes().FromBytes<TestModel>());
        Assert.Null(Array.Empty<byte>().FromBytes<TestModel>());
        Assert.Null(nullBytes.FromBytes<TestModel>());
    }

    [Fact]
    public void NonGenericTypeBytesNullTest()
    {
        object? nullModel = null;
        byte[]? nullBytes = null;
        Assert.Null(nullModel.ToBytes(typeof(object)).FromBytes(typeof(object)));
        Assert.Null(Array.Empty<byte>().FromBytes(typeof(object)));
        Assert.Null(nullBytes.FromBytes(typeof(object)));
    }

    [Fact]
    public void ObjectBytesTest()
    {
        var testModel = TestModelHelper.Create();
        var bytes = testModel.ToBytes(typeof(TestModel));
        var result = (TestModel)bytes.FromBytes(typeof(TestModel))!;

        Assert.Equal(testModel, result);
    }
}
