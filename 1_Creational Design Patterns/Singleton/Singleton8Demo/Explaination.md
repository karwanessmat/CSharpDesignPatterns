# Lazy Singleton Pattern

The `LazySingleton` class is an implementation of the Singleton design pattern which ensures that a class has only one instance and that the instance is created lazily, i.e., the instance is not created until it is actually needed. This can lead to performance improvements, particularly during application startup or when the instance creation is resource-intensive and might not be needed at all during the application's lifetime.

## Implementation

The implementation uses the `System.Lazy<T>` type, which is thread-safe and provides a simple way to work with lazy initialization in .NET.

## Structure

- `private static readonly Lazy<LazySingleton>`: A static variable that holds the lazy-initialized instance of the Singleton.
- `private LazySingleton()`: A private constructor that prevents instance creation outside the class.
- `public static LazySingleton Instance`: A public static property that provides access to the instance.

## How It Works

1. **Lazy Initialization**: The instance is not created when the application starts. Instead, it is created when the `Instance` property is accessed for the first time.

2. **Lifetime**: After the instance is created, it remains in the application's memory for subsequent use. It does not get destroyed after the task is finished.

3. **Thread Safety**: The `System.Lazy<T>` type handles thread safety, ensuring that only one instance is created even when accessed by multiple threads simultaneously.

## Usage

To use the `LazySingleton`, call the `Instance` property followed by the method you want to execute:

```csharp
LazySingleton.Instance.DoAction();
