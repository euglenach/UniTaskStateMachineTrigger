using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace UniTaskStateMachineTriggers
{
    public class UniTaskStateMachineTrigger : StateMachineBehaviour
    {
        public class OnStateInfo
        {
            public Animator Animator{get;private set;}
            public AnimatorStateInfo StateInfo{get;private set;}
            public int LayerIndex{get;private set;}

            public OnStateInfo(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
            {
                Animator = animator;
                StateInfo = stateInfo;
                LayerIndex = layerIndex;
            }
        }

        public class OnStateMachineInfo
        {
            public Animator Animator{get;private set;}
            public int StateMachinePathHash{get;private set;}

            public OnStateMachineInfo(Animator animator, int stateMachinePathHash)
            {
                Animator = animator;
                StateMachinePathHash = stateMachinePathHash;
            }
        }

        // OnStateEnter

        private AsyncReactiveProperty<OnStateInfo> onStateEnter;

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(onStateEnter != null) onStateEnter.Value = new OnStateInfo(animator, stateInfo, layerIndex);
        }

        public UniTask<OnStateInfo> OnStateEnterAsync(CancellationToken cancellationToken = default)
        {
            if(onStateEnter == null) onStateEnter = new AsyncReactiveProperty<OnStateInfo>(default);
            return onStateEnter.WaitAsync(cancellationToken);
        }

        public IUniTaskAsyncEnumerable<OnStateInfo> OnStateEnterAsAsyncEnumerable()
        {
            return onStateEnter.WithoutCurrent();
        }

        // OnStateUpdate

        private AsyncReactiveProperty<OnStateInfo> onStateUpdate;

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(onStateUpdate != null) onStateUpdate.Value = new OnStateInfo(animator, stateInfo, layerIndex);
        }

        public UniTask<OnStateInfo> OnStateUpdateAsync(CancellationToken cancellationToken = default)
        {
            if(onStateUpdate == null) onStateUpdate = new AsyncReactiveProperty<OnStateInfo>(default);
            return onStateUpdate.WaitAsync(cancellationToken);
        }

        public IUniTaskAsyncEnumerable<OnStateInfo> OnStateUpdateAsAsyncEnumerable()
        {
            return onStateUpdate.WithoutCurrent();
        }

        // OnStateExit

        private AsyncReactiveProperty<OnStateInfo> onStateExit;

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(onStateExit != null) onStateExit.Value = new OnStateInfo(animator, stateInfo, layerIndex);
        }

        public UniTask<OnStateInfo> OnStateExitAsync(CancellationToken cancellationToken = default)
        {
            if(onStateExit == null) onStateExit = new AsyncReactiveProperty<OnStateInfo>(default);
            return onStateExit.WaitAsync(cancellationToken);
        }

        public IUniTaskAsyncEnumerable<OnStateInfo> OnStateExitAsAsyncEnumerable()
        {
            return onStateExit.WithoutCurrent();
        }

        // OnStateMove

        // private AsyncReactiveProperty<OnStateInfo> onStateMove;
        //
        // public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        // {
        //     if(onStateMove != null)onStateMove.Value = new OnStateInfo(animator, stateInfo, layerIndex);
        // }
        //
        // public UniTask<OnStateInfo> OnStateMoveAsAsync(CancellationToken cancellationToken = default)
        // {
        //     if(onStateMove == null) onStateMove = new AsyncReactiveProperty<OnStateInfo>(default);
        //     return onStateMove.WaitAsync(cancellationToken);
        // }
        //
        // public IUniTaskAsyncEnumerable<OnStateInfo> OnStateMoveAsAsyncEnumerable()
        // {
        //     return onStateMove.WithoutCurrent();
        // }

        // OnStateIK

        private AsyncReactiveProperty<OnStateInfo> onStateIK;

        public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if(onStateIK != null) onStateIK.Value = new OnStateInfo(animator, stateInfo, layerIndex);
        }

        public UniTask<OnStateInfo> OnStateIKAsync(CancellationToken cancellationToken = default)
        {
            if(onStateIK == null) onStateIK = new AsyncReactiveProperty<OnStateInfo>(default);
            return onStateIK.WaitAsync(cancellationToken);
        }

        public IUniTaskAsyncEnumerable<OnStateInfo> OnStateIKAsAsyncEnumerable()
        {
            return onStateIK.WithoutCurrent();
        }

        // OnStateMachineEnter

        private AsyncReactiveProperty<OnStateMachineInfo> onStateMachineEnter;

        public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
        {
            if(onStateMachineEnter != null)
                onStateMachineEnter.Value = new OnStateMachineInfo(animator, stateMachinePathHash);
        }

        public UniTask<OnStateMachineInfo> OnStateMachineEnterAsync(CancellationToken cancellationToken = default)
        {
            if(onStateMachineEnter == null)
                onStateMachineEnter = new AsyncReactiveProperty<OnStateMachineInfo>(default);
            return onStateMachineEnter.WaitAsync(cancellationToken);
        }

        public IUniTaskAsyncEnumerable<OnStateMachineInfo> OnStateMachineEnterAsAsyncEnumerable()
        {
            return onStateMachineEnter.WithoutCurrent();
        }

        // OnStateMachineExit

        private AsyncReactiveProperty<OnStateMachineInfo> onStateMachineExit;

        public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
        {
            if(onStateMachineExit != null)
                onStateMachineExit.Value = new OnStateMachineInfo(animator, stateMachinePathHash);
        }

        public UniTask<OnStateMachineInfo> OnStateMachineExitAsync(CancellationToken cancellationToken = default)
        {
            if(onStateMachineExit == null) onStateMachineExit = new AsyncReactiveProperty<OnStateMachineInfo>(default);
            return onStateMachineExit.WaitAsync(cancellationToken);
        }

        public IUniTaskAsyncEnumerable<OnStateMachineInfo> OnStateMachineExitAsAsyncEnumerable()
        {
            return onStateMachineExit.WithoutCurrent();
        }
    }
}