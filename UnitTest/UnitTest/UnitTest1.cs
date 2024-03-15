using Lab1;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAtLeastOneCorrect()
        {
            Problem problem = new Problem(10, 0);
            Assert.IsNotNull(problem);
            Result result = problem.solve(Problem.MAX_WEIGHT);
            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.total_weight);
        }

        [TestMethod]
        public void EmptyResult()
        {
            Problem problem = new Problem(10, 0);
            Assert.IsNotNull(problem);
            Result result = problem.solve(0);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.total_weight);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.result.Count);

        }

        [TestMethod]
        public void ItemOrderEffect()
        {
            Problem problem = new Problem(10, 0);
            Assert.IsNotNull(problem);
            Result result1 = problem.solve(Problem.MAX_WEIGHT);
            Assert.IsNotNull(result1);
            problem.items.Reverse();
            Result result2 = problem.solve(Problem.MAX_WEIGHT);
            Assert.IsNotNull(result2);
            Assert.AreEqual(result1.total_value, result2.total_value);
            Assert.AreEqual(result1.total_weight, result2.total_weight);
        }

        [TestMethod]
        public void CheckForInstance()
        {
            Problem problem = new Problem(10, 434180);
            Assert.IsNotNull(problem);
            Result result = problem.solve(10);
            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.total_weight);
            Assert.AreEqual(20, result.total_value);

            Assert.AreEqual(result.result[0].value, 9);
            Assert.AreEqual(result.result[1].value, 4);
            Assert.AreEqual(result.result[2].value, 7);
            Assert.AreEqual(result.result[0].weight, 1);
            Assert.AreEqual(result.result[1].weight, 2);
            Assert.AreEqual(result.result[2].weight, 5);

            Assert.AreEqual(result.result.Count, 3);

        }

        //own tests

        [TestMethod]
        public void EmptyProblem()
        {
            Problem problem = new Problem(0, 0);
            Assert.IsNotNull(problem);
            Result result = problem.solve(10);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.total_weight);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.result.Count);

        }

        [TestMethod]
        public void SolveProblemWithNegativeCapacity()
        {
            Problem problem = new Problem(10, 0);
            Assert.IsNotNull(problem);
            Result result = problem.solve(-10);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.total_weight);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.result.Count);

        }

        [TestMethod]
        public void ItemWithOnlyNonNegativeValues()
        {
            Item item = new Item(-10, -20);
            Assert.IsNotNull(item);
            Assert.AreEqual(0, item.value);
            Assert.AreEqual(0, item.weight);
        }

        [TestMethod]
        public void ProblemWithNegativeN()
        {
            Problem problem = new Problem(-5, 0);
            Assert.IsNotNull(problem);
            Result result = problem.solve(10);
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.total_weight);
            Assert.AreEqual(0, result.total_value);
            Assert.AreEqual(0, result.result.Count);

        }

    }
}