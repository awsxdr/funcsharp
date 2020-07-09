﻿






namespace Func.UnitTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Threading.Tasks;

    [TestFixture]
    public partial class TeeExtensionMethodsTests
    {

        [Test]
        public void Tee_Curries_With2ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With2ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With2ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return Task.CompletedTask;
            }

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With2ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return Task.CompletedTask;
            }

            await 2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public void Tee_Curries_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2) =>
                result = $"{argument1}, {argument2}";

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return result.ToTask();
            }

            await Task.FromResult(2).Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With2ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2)
            {
                result = $"{argument1}, {argument2}";
                return result.ToTask();
            }

            await 2.Tee(TestMethod, 1);

            result.Should().Be("1, 2");
        }


        [Test]
        public void Tee_Curries_With3ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With3ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With3ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return Task.CompletedTask;
            }

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With3ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return Task.CompletedTask;
            }

            await 3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public void Tee_Curries_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3) =>
                result = $"{argument1}, {argument2}, {argument3}";

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return result.ToTask();
            }

            await Task.FromResult(3).Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With3ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3)
            {
                result = $"{argument1}, {argument2}, {argument3}";
                return result.ToTask();
            }

            await 3.Tee(TestMethod, 1, 2);

            result.Should().Be("1, 2, 3");
        }


        [Test]
        public void Tee_Curries_With4ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With4ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With4ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return Task.CompletedTask;
            }

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With4ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return Task.CompletedTask;
            }

            await 4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public void Tee_Curries_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return result.ToTask();
            }

            await Task.FromResult(4).Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With4ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}";
                return result.ToTask();
            }

            await 4.Tee(TestMethod, 1, 2, 3);

            result.Should().Be("1, 2, 3, 4");
        }


        [Test]
        public void Tee_Curries_With5ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With5ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With5ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return Task.CompletedTask;
            }

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With5ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return Task.CompletedTask;
            }

            await 5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public void Tee_Curries_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return result.ToTask();
            }

            await Task.FromResult(5).Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With5ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}";
                return result.ToTask();
            }

            await 5.Tee(TestMethod, 1, 2, 3, 4);

            result.Should().Be("1, 2, 3, 4, 5");
        }


        [Test]
        public void Tee_Curries_With6ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With6ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With6ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return Task.CompletedTask;
            }

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With6ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return Task.CompletedTask;
            }

            await 6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public void Tee_Curries_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return result.ToTask();
            }

            await Task.FromResult(6).Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With6ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}";
                return result.ToTask();
            }

            await 6.Tee(TestMethod, 1, 2, 3, 4, 5);

            result.Should().Be("1, 2, 3, 4, 5, 6");
        }


        [Test]
        public void Tee_Curries_With7ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";

            7.Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With7ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";

            await Task.FromResult(7).Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With7ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";
                return Task.CompletedTask;
            }

            await Task.FromResult(7).Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With7ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";
                return Task.CompletedTask;
            }

            await 7.Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public void Tee_Curries_With7ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";

            7.Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With7ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";

            await Task.FromResult(7).Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With7ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";
                return result.ToTask();
            }

            await Task.FromResult(7).Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With7ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}";
                return result.ToTask();
            }

            await 7.Tee(TestMethod, 1, 2, 3, 4, 5, 6);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7");
        }


        [Test]
        public void Tee_Curries_With8ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";

            8.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With8ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";

            await Task.FromResult(8).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With8ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";
                return Task.CompletedTask;
            }

            await Task.FromResult(8).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With8ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";
                return Task.CompletedTask;
            }

            await 8.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public void Tee_Curries_With8ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";

            8.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With8ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";

            await Task.FromResult(8).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With8ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";
                return result.ToTask();
            }

            await Task.FromResult(8).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With8ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}";
                return result.ToTask();
            }

            await 8.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8");
        }


        [Test]
        public void Tee_Curries_With9ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";

            9.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With9ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";

            await Task.FromResult(9).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With9ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";
                return Task.CompletedTask;
            }

            await Task.FromResult(9).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With9ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";
                return Task.CompletedTask;
            }

            await 9.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public void Tee_Curries_With9ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";

            9.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With9ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";

            await Task.FromResult(9).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With9ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";
                return result.ToTask();
            }

            await Task.FromResult(9).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With9ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}";
                return result.ToTask();
            }

            await 9.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9");
        }


        [Test]
        public void Tee_Curries_With10ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";

            10.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With10ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";

            await Task.FromResult(10).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With10ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";
                return Task.CompletedTask;
            }

            await Task.FromResult(10).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With10ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";
                return Task.CompletedTask;
            }

            await 10.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public void Tee_Curries_With10ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";

            10.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With10ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";

            await Task.FromResult(10).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With10ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";
                return result.ToTask();
            }

            await Task.FromResult(10).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With10ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}";
                return result.ToTask();
            }

            await 10.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }


        [Test]
        public void Tee_Curries_With11ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";

            11.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With11ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";

            await Task.FromResult(11).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With11ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";
                return Task.CompletedTask;
            }

            await Task.FromResult(11).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With11ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";
                return Task.CompletedTask;
            }

            await 11.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public void Tee_Curries_With11ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";

            11.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With11ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";

            await Task.FromResult(11).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With11ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";
                return result.ToTask();
            }

            await Task.FromResult(11).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With11ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}";
                return result.ToTask();
            }

            await 11.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }


        [Test]
        public void Tee_Curries_With12ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";

            12.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With12ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";

            await Task.FromResult(12).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With12ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";
                return Task.CompletedTask;
            }

            await Task.FromResult(12).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With12ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";
                return Task.CompletedTask;
            }

            await 12.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public void Tee_Curries_With12ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";

            12.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With12ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";

            await Task.FromResult(12).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With12ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";
                return result.ToTask();
            }

            await Task.FromResult(12).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With12ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}";
                return result.ToTask();
            }

            await 12.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
        }


        [Test]
        public void Tee_Curries_With13ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";

            13.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With13ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";

            await Task.FromResult(13).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With13ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";
                return Task.CompletedTask;
            }

            await Task.FromResult(13).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With13ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";
                return Task.CompletedTask;
            }

            await 13.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public void Tee_Curries_With13ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";

            13.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With13ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";

            await Task.FromResult(13).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With13ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";
                return result.ToTask();
            }

            await Task.FromResult(13).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With13ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}";
                return result.ToTask();
            }

            await 13.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13");
        }


        [Test]
        public void Tee_Curries_With14ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";

            14.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With14ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";

            await Task.FromResult(14).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With14ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";
                return Task.CompletedTask;
            }

            await Task.FromResult(14).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With14ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";
                return Task.CompletedTask;
            }

            await 14.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public void Tee_Curries_With14ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";

            14.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With14ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";

            await Task.FromResult(14).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With14ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";
                return result.ToTask();
            }

            await Task.FromResult(14).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With14ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}";
                return result.ToTask();
            }

            await 14.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14");
        }


        [Test]
        public void Tee_Curries_With15ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";

            15.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With15ArgumentsInAction()
        {
            var result = string.Empty;

            void TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";

            await Task.FromResult(15).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With15ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";
                return Task.CompletedTask;
            }

            await Task.FromResult(15).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With15ArgumentsInAction()
        {
            var result = string.Empty;

            Task TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";
                return Task.CompletedTask;
            }

            await 15.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public void Tee_Curries_With15ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";

            15.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Tee_CurriesFromTask_With15ArgumentsInFunc()
        {
            var result = string.Empty;

            string TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15) =>
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";

            await Task.FromResult(15).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Tee_CurriesFromTaskWithTask_With15ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";
                return result.ToTask();
            }

            await Task.FromResult(15).Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }

        [Test]
        public async Task Tee_CurriesWithTask_With15ArgumentsInFunc()
        {
            var result = string.Empty;

            Task<string> TestMethod(int argument1, int argument2, int argument3, int argument4, int argument5, int argument6, int argument7, int argument8, int argument9, int argument10, int argument11, int argument12, int argument13, int argument14, int argument15)
            {
                result = $"{argument1}, {argument2}, {argument3}, {argument4}, {argument5}, {argument6}, {argument7}, {argument8}, {argument9}, {argument10}, {argument11}, {argument12}, {argument13}, {argument14}, {argument15}";
                return result.ToTask();
            }

            await 15.Tee(TestMethod, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

            result.Should().Be("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15");
        }


    }
}
