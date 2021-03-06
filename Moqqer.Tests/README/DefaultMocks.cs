﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace MoqqerNamespace.Tests.README
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DefaultMocksTests
    {
        private Moqqer _moq;

        [SetUp]
        public void A_TestSetup()
        {
            _moq = new Moqqer();
        }

        [Test]
        public void String()
        {
            _moq.Object<string>().Should().Be(string.Empty);
        }

        [Test]
        public void List()
        {
            MoqObjectOfShouldReturn<List<int>, List<int>>();
        }

        [Test]
        public void IList()
        {
            MoqObjectOfShouldReturn<IList<int>, List<int>>();
        }

        [Test]
        public void ObservableCollection()
        {
            var obs = _moq.Object<ObservableCollection<int>>();
            var list = _moq.List<int>();

            list.Add(100);

            obs.Should().BeEquivalentTo(new[] {100});

            obs.Remove(100);

            list.Should().BeEmpty("integer was removed from Observeable Collection");
        }

        [Test]
        public void TaskT()
        {
            var task = _moq.Object<Task<string>>();

            task.Should().NotBeNull();

            task.IsCompleted.Should().BeTrue();

            task.Result.Should().Be(_moq.Object<string>());
        }

        [Test]
        public void Task()
        {
            var task = _moq.Object<Task>();

            task.Should().NotBeNull();

            task.IsCompleted.Should().BeTrue();
        }
        
        public void MoqObjectOfShouldReturn<TType, TMockType>() where TType : class
        {
            _moq.Object<TType>()
                .Should().BeOfType<TMockType>()
                .Which.Should().NotBeNull();

            var obj1 = _moq.Object<TType>();
            var obj2 = _moq.Object<TType>();

            obj1.Should().BeSameAs(obj2);
        }
    }
}