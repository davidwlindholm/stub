public class CustomerHandler {
    private IDatabase CustomerData;
    public CustomerHandler(IDatabase database) {
        // In real scenario, this would be injected.
        CustomerData = database;
    }

    public List<Customer> GetCustomers() {
        return CustomerData.GetCustomers().ToList();
    }

    public Customer GetCustomerById(int id) {
        return CustomerData.GetCustomerById(id);
    }
}