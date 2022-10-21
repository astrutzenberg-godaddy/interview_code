using FluentAssertions;
using InterviewProject.Backend;
using System.Collections.Generic;
using Xunit;

namespace InterviewProject.Tests;

public class DeDupeUnitTests
{
    [Fact]
    public void EmptyListTest()
    {

        List<int> l = new List<int>();
        IList<int> result = CollectionManipulation.DeDupe(l);

        //FluentAssertions
        result.Count.Should().Be(0, "Empty list has nothing to dedupe");
    }

    [Fact]
    public void SingleItemTest()
    {
        List<int> l = new List<int>(new int[] { 42 });
        IList<int> result = CollectionManipulation.DeDupe(l);

        //FluentAssertions
        result.Count.Should().Be(1, "Single Item list should have one item");
        result[0].Should().Be(42, "Single item in list was not expected value");
    }

    [Fact]
    public void MultiItemUniqueTest()
    {
        List<int> l = new List<int>(new int[] { 42,99,36 });
        IList<int> result = CollectionManipulation.DeDupe(l);

        //FluentAssertions
        result.Count.Should().Be(l.Count, "Multi Item list count mismatch");
    }

    [Fact]
    public void ListWithDupesTest()
    {
        List<int> l = new List<int>(new int[] { 42, 99, 36,42, 99 });
        IList<int> result = CollectionManipulation.DeDupe(l);

        //FluentAssertions
        result.Count.Should().Be(3,"multi item list count mismatch");
    }

    [Fact]
    public void ListComparisonTest()
    {
        List<int> l = new List<int>(new int[] { 42, 99, 36, 42, 99 });
        IList<int> result = CollectionManipulation.DeDupe(l);

        //FluentAssertions
        l.Count.Should().Be(5, "Original List Was changed");
        result.Count.Should().Be(3, "Multi Item dedupe list should drop two values");
    }
}