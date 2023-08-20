#include<stdio.h>
int main()
{
	int num1,num2,result=0;
	char op;
	printf("Enter 2 numbers:");
	scanf("%d%d",&num1,&num2);
	printf("enter (+,-,*,/)");
	fflush(stdin);
	scanf("%ch",&op);
	switch(op)
{
		case '+':
			result=num1+num2;
			break;
			case '-':
			result=num1-num2;
				break;
				case '*':
					result=num1*num2;
						break;
					case '/':
					result=num1/num2;
						break;
								default:
									printf("Invalid op");
									break;
							}
								
								printf("\nresult=%d",result);
}
