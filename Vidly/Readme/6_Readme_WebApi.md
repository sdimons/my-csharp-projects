##  Building an API
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

