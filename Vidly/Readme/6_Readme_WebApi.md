﻿##  Building an API
#### 1. Create the folder "Api" in the folder "Controllers"
#### 2. Add ASP.NET Web API 2 Controller to project (CustomersController).

The Global.asax.cs file in the project may require additional changes to enable ASP.NET Web API.

1. Add the following namespace references:

    using System.Web.Http;
    using System.Web.Routing;

2. If the code does not already define an Application_Start method, add the following method:

    protected void Application_Start()
    {
    }

3. Add the following lines to the beginning of the Application_Start method:

    GlobalConfiguration.Configure(WebApiConfig.Register);


Controller:
```
// GET api/customers
public IEnumerable<Customer> GetCustomers()
{...}
```

```
// GET api/customers/1
public Customer GetCustomer(int id)
{...}
```

```
// POST api/customers
[HttpPost]
public Customer CreateCustomer(Customer customer)
{...}
```

```
// PUT api/customers/1
[HttpPut]
public void UpdateCustomer(int id, Customer customer)
{...}
```

```
// DELETE api/cistomers/1
[HttpDelete]
public void DeleteCustomer(int id)
{...}
```

## Testing an API
Search in Google : "postman rest client"

##  Data Transfer Objects (DTO)

##  Auto Mapper (to map objects)
```
PM> install-package automapper -version:4.1
```

Create a mapping profile first:
```
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
```

Load the mapping profile during application startup (in global.asax.cs):
```
Mapper.Initialize(c => c.AddProfile<MappingProfile>());
```

To map objects:
```
return Mapper.Map<Customer,CustomerDto>(customer);
```

```
var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
```

Or to map to an existing object:
```
Mapper.Map(customerDto, customerInDb);
```

## Using Camel Notation
In WebApiConfig:
```
    var settings = config.Formatters.JsonFormatter.SerializerSettings;
    settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    settings.Formatting = Formatting.Indented;
```

## IHttpActionResult

```
[HttpPost]
public IHttpActionResult CreateCustomer(CustomerDto customerDto)
{...}
```

Helper methods:
```
return BadRequest();
```

```
return NotFound();
```

```
return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
```

```
return Ok(Mapper.Map<Customer, CustomerDto>(customer));
```
