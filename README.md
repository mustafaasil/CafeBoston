
Create a class library project named 
  CafeBoston.DATA and create 4 classes and 1 enum as described below



Product
* ProductName: string
* UniPrice: decimal
- ToString(): string

OrderDetail
* ProductName: string
* UniPrice: decimal
* Quantity: int
* TotalPriceTRY: string-readonly
- TotalPrice(): decimal

OrderState (Active = 0, Paid = 1, Canceled = 2)

Order
* TableNo: int
* State: SiparisDurum
* PaidAmount: decimal
* StartTime: DateTime?
* EndTime: DateTime?
* OrderDetails: List<SiparisDetay>
* TotalPriceTRY: string-readonly
- TotalPrice(): decimal

CafeData
* TableCount: int
* Products: List<Urun>
* ActiveOrders: List<Siparis>
* PastOrders: List<Siparis>


