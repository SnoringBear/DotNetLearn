在 C# 中，`async` 和 `await` 是用于简化异步编程的重要关键字。它们让你能够更容易地编写非阻塞代码，避免在执行 I/O 操作时阻塞主线程（比如 UI 线程），从而提高程序的响应性。

### `async` 关键字

`async` 用于标记一个方法是异步方法，意味着这个方法会包含异步操作。一个异步方法通常返回 `Task` 或 `Task<T>` 类型，表示它会在某个时刻完成，并可能返回一个值。

```
csharp复制编辑public async Task<int> FetchDataAsync()
{
    // 异步操作
    await Task.Delay(2000);  // 模拟异步操作
    return 42;
}
```

### `await` 关键字

`await` 用于等待一个异步操作完成，它只能在 `async` 方法中使用。当执行到 `await` 时，当前方法会暂停，直到所等待的异步任务完成。期间，控制权会返回到调用者，允许其他操作继续执行，从而不会阻塞线程。

```
csharp复制编辑public async Task MainMethodAsync()
{
    int result = await FetchDataAsync();  // 等待异步任务完成
    Console.WriteLine(result);
}
```

### 关键点

1. **非阻塞**：`async` 和 `await` 使得代码在等待任务完成时不会阻塞线程，允许 UI 线程或其他操作继续执行。

2. **异常处理**：在异步方法中，异常会以正常的方式传递，`await` 会捕获它们。你可以使用 `try-catch` 来捕获异步方法中的异常。

   ```
   csharp复制编辑public async Task MainMethodAsync()
   {
       try
       {
           int result = await FetchDataAsync();
           Console.WriteLine(result);
       }
       catch (Exception ex)
       {
           Console.WriteLine($"错误: {ex.Message}");
       }
   }
   ```

3. **异步方法返回值**：异步方法一般返回 `Task` 或 `Task<T>`，表示方法完成的状态或返回的结果。没有返回值时，返回 `Task`。

4. **等待多个任务**：你可以使用 `Task.WhenAll` 或 `Task.WhenAny` 等方法来等待多个任务并行执行。

   ```
   csharp复制编辑public async Task MainMethodAsync()
   {
       var task1 = FetchDataAsync();
       var task2 = FetchDataAsync();
       
       // 等待两个任务都完成
       await Task.WhenAll(task1, task2);
       
       Console.WriteLine("两个任务都完成");
   }
   ```

### 注意事项

- `async` 方法默认会返回 `Task` 或 `Task<T>`，如果是一个没有返回值的异步方法，可以使用 `Task`。
- 如果一个异步方法没有 `await` 表达式，它会立即返回一个已完成的任务，可能并没有执行异步操作。

```
csharp复制编辑public async Task NoOpAsync()
{
    // 没有异步操作，方法会立即返回
    await Task.CompletedTask;
}
```

通过使用 `async` 和 `await`，你能够以更简单的方式编写异步代码，避免了传统回调或线程池的复杂性。