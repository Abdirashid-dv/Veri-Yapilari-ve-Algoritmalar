using DataStructures.Array;

namespace ArrayTests;

public class StaticArrayTests
{
    private StaticArray<char> _array;
    public StaticArrayTests()
    {
        // Arrange
        _array = new StaticArray<char>();
        _array.SetItem(0, 'a');
        _array.SetItem(1, 'b');
        _array.SetItem(2, 'c');
        _array.SetItem(3, 'd');
    }

    [Fact]
    public void DefaultConstructor_InitializesArrayWithCorrectLength()
    {
        // Act
        var length = _array.Length;

        // Assert
        Assert.Equal(4, length);
    }

    [Fact]
    public void Get_Item_Test()
    {
        // act
        var item = _array.GetItem(2);

        // assert
        Assert.Equal('c', item);
    }

    [Fact]
    public void SetItem_ChangesValue()
    {
        // act
        _array.SetItem(3, 'e');
        var item = _array.GetItem(3);

        // assert
        Assert.Equal('e', item);
    }

    [Fact]
    public void SetItem_ThrowsIndexOutOfRangeException_ForInvalidIndex()
    {
        // assert
        Assert.Throws<IndexOutOfRangeException>(() => _array.SetItem(-1, 'f'));
    }

    [Fact]
    public void GetItem_ThrowsIndexOutOfRangeException_ForInvalidIndex()
    {
        Assert.Throws<IndexOutOfRangeException>(() => _array.GetItem(4));
    }

    [Fact]
    public void Length_Test()
    {
        var items = new StaticArray<int>(new int[] { 1, 2, 3, 4, 5, 6 });

        Assert.Equal(6, items.Length);
    }

    [Fact]
    public void Constructor_with_IEnumerable_Parameter_Test()
    {
        // Act
        var items = new StaticArray<int>(new int[] { 1, 2, 3, 4, 5, 6 }); // StaticArray<int>(list);
        var length = items.Length;
        var item = items.GetItem(0);

        // Assert
        Assert.Equal(6, length);
        Assert.Equal(1, item);
    }

    [Fact]
    public void ConstructorWithCollection_InitializesArrayWithCorrectLengthAndValues()
    {
        // Act
        var items = new StaticArray<int>(new int[] { 1, 2, 3, 4, 5, 6 });

        // Assert
        Assert.Equal(6, items.Length);
        Assert.Equal(1, items.GetItem(0));
        Assert.Equal(2, items.GetItem(1));
        Assert.Equal(3, items.GetItem(2));
        Assert.Equal(4, items.GetItem(3));
        Assert.Equal(5, items.GetItem(4));
        Assert.Equal(6, items.GetItem(5));
    }

    [Fact]
    public void GetEnumerator_ReturnsAllItemsInArray()
    {
        // Arrange
        var enumerator = _array.GetEnumerator();
        var items = new char[_array.Length];
        int i = 0;

        //Act
        while (enumerator.MoveNext())
        {
            items[i] = (char)enumerator.Current;
            i++;
        }

        // Assert
        Assert.Collection(items,
        item => Assert.Equal('a', item),
        item => Assert.Equal('b', item),
        item => Assert.Equal('c', item),
        item => Assert.Equal('d', item)
        );
    }
}