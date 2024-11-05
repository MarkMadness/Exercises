using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_WhenCalled_AddsObjectToStack()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            var count = stack.Count;

            Assert.That(count, Is.EqualTo(1));
        }
        [Test]
        public void Push_NullPassed_ThrowArgumentNullException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Pop_WhenCalled_RemovesObjectFromStack()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            var count = stack.Count;

            Assert.That(count, Is.EqualTo(1));
        }
        [Test]
        [Ignore("My solution. Test below is better")]
        public void Pop_CountIsZero_ThrowsInvalidOperationException()
        {
            var stack = new Stack<int>();

            var count = stack.Count;

            Assert.That(() => count.Equals(0), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_StackIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new Stack<int>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_WhenCalled_ReturnLastElementInStack()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            var peek = stack.Peek();

            Assert.That(peek, Is.EqualTo(2));
        }
        [Test]
        public void Peek_CountIsZero_ThrowInvalidOperationException()
        {
            var stack = new Stack<int>();

            // Assert.That(() => stack.Count.Equals(0), Throws.InvalidOperationException);
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_StackPopulated_ReturnObjectOnTopOfStack()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(1));
        }
        [Test]
        public void Peek_StackPopulated_DoesNotRemoveObjectOnTopOfStack()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.That(stack.Peek(), Is.EqualTo(2));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }
    }
}