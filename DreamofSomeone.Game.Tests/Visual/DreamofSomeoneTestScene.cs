using osu.Framework.Testing;

namespace DreamofSomeone.Game.Tests.Visual
{
    public abstract partial class DreamofSomeoneTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new DreamofSomeoneTestSceneTestRunner();

        private partial class DreamofSomeoneTestSceneTestRunner : DreamofSomeoneGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
