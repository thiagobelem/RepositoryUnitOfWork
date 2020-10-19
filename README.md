# RepositoryUnitOfWork

A generic implementation of the Repository Pattern with Unit of Work in C# and EF6.

## Repository

*Mediates between the domain and data mapping layers using a collection-like interface for accessing domain objects.*

Benefits
* Minimizes duplicate query logic
* Decouples your application from persistence frameworks


## Unit of Work

*Maintains a list of objects affected by a business transaction and coordinates the writing out of changes and the resolution of concurrency problems.*

Benefits
* Manage transactions
* Ensures that when using multiple repositories, they share a single database context


##### References
Martin Fowler - [Repository](https://martinfowler.com/eaaCatalog/repository.html) - [ Unit of Work](https://martinfowler.com/eaaCatalog/unitOfWork.html)
