# Data Stores

A data access pattern that transcends the implementation details of any given data store, with integrations to many popular storage systems and techniques.

In the simplest form, Data Stores lets you use a file folder as if it were a NoSQL data store. In fact, it could be called a 'No*DB*' data store, as it doesn't require the installation or configuration of a database engine at all. This folder can be stored on local disk, or one of any number of cloud file storage services.

In the most robust form, Data Stores lets you integrate to many different kinds of data storage services (such as document databases), while making code that is indifferent to the implementation details of these services. 

You can create a single data context that accesses data on any number of storage services using a single, unified interface. This interface is easy to mock, making the approach friendly to unit testing as well.

Data Store integrations are provided for DocumentDb, Local Storage, Blob Storage, and Google Drive.

Serialization integrations are provided for JSON, YAML, XML, Protobuf, and Bond. Note that some serializers have special requirements for the data classes to be serialized.

Optional compression via GZIP is provided as well. This can make a 10:1 difference in stored / transferred data payload size for formats like JSON.

Much more is planned in the [roadmap](docs/roadmap.md).