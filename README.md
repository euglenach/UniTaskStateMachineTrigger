# UniTaskStateMachineTrigger
UniTask version of UniRx's ObservableStateMachineTrigger

# Usage

```C#
var animator = GetComponent<Animator>();

// get UniTaskStateMachineTrigger
var trigger = animator.GetBehaviour<UniTaskStateMachineTrigger>();

// await StateMachine event
await trigger.OnStateEnterAsync();
```

However, this may result in unintended task completion.
By passing a delegate to the method, you can get the results of only those that meet the conditions.

```C#
await trigger.OnStateEnterAsync(info => info.StateInfo.IsName("Walk"));
```

If you want to take multiple results, as in the case of the ObseverableStateMachineTrigger, you can also use UniTaskAsyncEnumerable to get the results.
Asynchronous processing is queued because of the internal use of AsyncReactiveProperty.

```C#
trigger.OnStateExitAsAsyncEnumerable()
       .Where(info => info.StateInfo.fullPathHash == lastStateHash)
       .Where(info => info.StateInfo.normalizedTime <= 1.0f)
       .ForEachAwaitAsync(async info =>
       {
           Debug.Log("exit state");
           await UniTask.Delay(1000);
       });
```
