# RequestR with Ninject

## Getting Started

### 1) Setup Services

**Note**: Include `RequestR.Extensions.Ninject` nuget package.

```csharp
IKernel kernel = new StandardKernel();
kernel.AddRequestBus();
```

### 2) Setup the Request Bus

Retrieve the `RequestBus` instance and call the `RegisterAllHandlers()` method.

```csharp
RequestBus requestBus = kernel.Get<RequestBus>();
requestBus.RegisterAllHandlers();
```

### 3) Send request

```csharp
PresentProductsRequest request = new PresentProductsRequest();
MyResponse response = requestBus.Send<MyRequest, MyResponse>(request);
```