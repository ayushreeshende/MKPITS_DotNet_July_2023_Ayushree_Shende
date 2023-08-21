#include<stdio.h>
void deposit(int amt,int bal);
void withdrawal(int amt,int bal);
void main()
{
	int amt,bal=1000;
	printf("enter amt");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrawal(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
printf("amt deposit,bal is=%d",bal);
}
void withdrawal(int amt,int bal)
{
	bal=bal-amt;
	printf("amt withdrawal,bal is=%d",bal);
}


//Algorithm:
//	1)start
//	2)define function deposit & withdrawal
//	3)declare amt ,bal=1000
//	4)accept amt
//	5)bal=bal+amt
//	6)print amt deposit
//	7)bal=bal-amt
//	8)print amt withdrawal
//	9)stop
