namespace BlazingPizza; 

public class OrderState{
    public bool ShowingConfigureDialog{get; set;}
    public Pizza ConfiguringPizza{get; set;}
    public Order Order{get; private set;} = new Order(); 
    
    public void ShowConfigureDialog(PizzaSpecial special){
        ConfiguringPizza = new Pizza(){
            Special = special, 
            SpecialId = special.Id, 
            Size = Pizza.DefaultSize, 
            Toppings = new List<PizzaTopping>()
        };
        ShowingConfigureDialog = true;

    } 

    public void ConfirmConfigurePizzaDialog(){
        Order.Pizzas.Add(ConfiguringPizza); 
        ConfiguringPizza = null; 
        ShowingConfigureDialog=false;


    }

    public void CancelConfigurePizzaDialog(){
        ConfiguringPizza = null; 
        ShowingConfigureDialog = false; 
    }





}

