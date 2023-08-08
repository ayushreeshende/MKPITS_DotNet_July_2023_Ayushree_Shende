#include<stdio.h>
void calculate(int num1,int num2,char op)
{
	int result=0;
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
						}	
			printf("result is %d\n",result);									
	}
	void main()
	{
		int num1,num2,result;
		char ch='y';
		char op;
		while(ch='y')
		{
	printf("Enter 2 numbers:");
	scanf("%d%d",&num1,&num2);
	printf("enter operator (+,-,*,/)\n");
	fflush(stdin);
	scanf("%c",&op);
	calculate(num1,num2,op);
	printf("do you want continue,press y\n");
	fflush(stdin);
	scanf("%c",&ch);
		}
	}
	
	
//Algorithm:
//	1)start
//	2)declare num1,num2,char op,result
//	3)operators +,-,*,/
//	4)print result
//	5)go to main function
//	6)accept 2 no
//	7)print operator
//	8)then caculate
//	9)stop
