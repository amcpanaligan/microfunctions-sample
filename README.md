# microfunctions-sample
A sample project for implementing Microservices using Azure Function Apps

# Requirements
1. All `Service Interfaces` should live in the `Infrastructure` project together with their respective `Messages: Request-Response`.
2. Ensure to "folder" them properly. For example models for the `DocumentService` should be put inside the `Infra/Messages/Documents` folder so that we can easily `filter` by `path` later on for CI/CD
3. Create a `Client` library/project that implements the same `IService` (from `infra`) interface. The `Client` class should only perform `HTTP` to the function apps contrary to the original `Service` implementation where it calls `gateways` and other classes.
4. Replace the injected `IService` implementation in the `Api` project with the `ServiceClient` instead of the `Service` class originally.
