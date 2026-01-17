using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities
    // Expected Result: Item with highest priority is dequeued
    // Defect(s) Found: Highest priority item is not removed from the queue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same highest priority
    // Expected Result: First item with highest priority is dequeued
    // Defect(s) Found: FIFO order is not preserved
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 1);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("A", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException with correct message
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}