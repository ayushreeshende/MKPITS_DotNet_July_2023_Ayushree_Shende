#include <stdio.h>
void main()
{
	char customer_name[10],product_name[10];
	int quantity,price,discount,total_amount;
	printf("enter customer name:");
	scanf("%s",&customer_name);
	printf("enter product name:");
	scanf("%s",&product_name);
	printf("enter price:");
	scanf("%d",&price);
	printf("enter quantity:");
	scanf("%d",&quantity);
	total_amount=price*quantity;
	printf("total_amount=%d\n",total_amount);
	if(total_amount>=1000)
	{
		discount=total_amount*0.04;
	}
	else if(total_amount>=500)
	{
		discount=total_amount*0.05;
	}
	else
	{
		discount=total_amount*0.01;
	}
	printf("\ncustomer_name=%s",customer_name);
	printf("\nproduct_name=%s",product_name);
	printf("\nprice=%d",price);
	printf("\ndiscount=%d",discount);
	total_amount=total_amount-discount;
	printf("\ntotal amount=%d",total_amount);
}
