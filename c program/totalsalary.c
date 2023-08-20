#include<stdio.h>
void main()
{
	float basic;
	float hra,da,total_salary;
	printf("enter basic");
	scanf("%f",&basic);
	hra=basic*0.35f;
	da=basic*0.45f;
	total_salary=hra+basic+da;
	printf("hra=%f\n",hra);
	printf("da=%f\n",da);
	printf("total_salary=%f",total_salary);
}
