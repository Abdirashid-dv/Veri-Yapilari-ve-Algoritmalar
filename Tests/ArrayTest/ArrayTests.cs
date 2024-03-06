using DataStructures.Array;

namespace Tests.ArrayTests;

public class ArrayTests
{

    private Array<char> _array;

    public ArrayTests()
    {
        _array = new Array<char>();
        _array.Add('h');
        _array.Add('e');
        _array.Add('l');
        _array.Add('l');
        _array.Add('o');
    }


    [Fact]
    public void Add_AddsElement_CountIncreases()
    {
        // act
        _array.Add('w');

        // assert
        Assert.Equal(6, _array.Count);

    }

    [Fact]
    public void RemoveAt_RemovesElement_CountDecreases()
    {
        // Act
        _array.RemoveAt(0);
        // _array.RemoveAt(2);

        // Assert
        Assert.Equal(4, _array.Count);
    }

    [Fact]
    public void RemoveAt_RemovesCorrectElement()
    {
        // Act
        var item = _array.RemoveAt(0);

        // Assert
        Assert.Equal('e', item);
    }

    [Fact]
    public void RemoveAt_ThrowsIndexOutOfRangeException_WhenIndexOutOfRange()
    {
        // Asser
        Assert.Throws<IndexOutOfRangeException>(() => _array.RemoveAt(6));
    }

    [Fact]
    public void Swap_SwapsElements()
    {

        // Act
        _array.Swap(0, 3);

        // Assert
        Assert.Equal('l', _array.GetItem(0));
        Assert.Equal('h', _array.GetItem(3));


    }

    [Fact]
    public void ShrinkArray_DoesNotShrinkCapacity_WhenCountIsGreaterThanQuarterOfCapacity()
    {
        // Act
        _array.RemoveAt(0);
        _array.RemoveAt(0);

        // Assert
        Assert.Equal(8, _array.Capacity);

    }

    [Fact]
    public void ShrinkArray_ShrinksCapacity_WhenCountIsLessThanQuarterOfCapacity()
    {
        _array.RemoveAt(0);
        _array.RemoveAt(0);
        _array.RemoveAt(0);

        // Assert
        Assert.Equal(4, _array.Capacity);

    }

    [Fact]
    public void Swap_Without_Additional_Variable()
    {
        // Arrange
        int a = 50;
        int b = 20;

        // Act
        a = a + b; // a = 70, b = 20
        b = a - b; // a = 70, b = 50
        a = a - b; // a = 20, b = 50


        // Assert
        Assert.Equal(20, a);
        Assert.Equal(50, b);
    }
}