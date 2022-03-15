using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace UniTaskStateMachineTriggers
{
    [DisallowMultipleComponent]
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

        public UniTask<OnStateInfo> OnStateEnterAsync(Func<OnStateInfo,bool> predicate = null, CancellationToken cancellationToken = default)
        {
            if(onStateEnter == null) onStateEnter = new AsyncReactiveProperty<OnStateInfo>(default);
            return OnStateMachineEventWaitCore(onStateEnter, predicate, cancellationToken);
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

        public UniTask<OnStateInfo> OnStateUpdateAsync(Func<OnStateInfo,bool> predicate = null, CancellationToken cancellationToken = default)
        {
            if(onStateUpdate == null) onStateUpdate = new AsyncReactiveProperty<OnStateInfo>(default);
            return OnStateMachineEventWaitCore(onStateUpdate, predicate, cancellationToken);
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

        public UniTask<OnStateInfo> OnStateExitAsync(Func<OnStateInfo,bool> predicate = null, CancellationToken cancellationToken = default)
        {
            if(onStateExit == null) onStateExit = new AsyncReactiveProperty<OnStateInfo>(default);
            return OnStateMachineEventWaitCore(onStateExit, predicate, cancellationToken);
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

        public UniTask<OnStateInfo> OnStateIKAsync(Func<OnStateInfo,bool> predicate = null, CancellationToken cancellationToken = default)
        {
            if(onStateIK == null) onStateIK = new AsyncReactiveProperty<OnStateInfo>(default);
            return OnStateMachineEventWaitCore(onStateIK, predicate, cancellationToken);
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

        public UniTask<OnStateMachineInfo> OnStateMachineEnterAsync(Func<OnStateMachineInfo,bool> predicate = null, CancellationToken cancellationToken = default)
        {
            if(onStateMachineEnter == null)
                onStateMachineEnter = new AsyncReactiveProperty<OnStateMachineInfo>(default);
            return OnStateMachineEventWaitCore(onStateMachineEnter,predicate,cancellationToken);
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

        public UniTask<OnStateMachineInfo> OnStateMachineExitAsync(Func<OnStateMachineInfo,bool> predicate = null, CancellationToken cancellationToken = default)
        {
            if(onStateMachineExit == null) onStateMachineExit = new AsyncReactiveProperty<OnStateMachineInfo>(default);
            return OnStateMachineEventWaitCore(onStateMachineExit,predicate,cancellationToken);
        }

        public IUniTaskAsyncEnumerable<OnStateMachineInfo> OnStateMachineExitAsAsyncEnumerable()
        {
            return onStateMachineExit.WithoutCurrent();
        }
        
        async UniTask<T> OnStateMachineEventWaitCore<T>(IReadOnlyAsyncReactiveProperty<T> asyncReactiveProperty,Func<T,bool> predicate,CancellationToken cancellationToken = default)
        {
            while(true)
            {
                var result = await asyncReactiveProperty.WaitAsync(cancellationToken);
                if(predicate == null || predicate(result))
                {
                    return result;
                }
            }
        }
    }
}
