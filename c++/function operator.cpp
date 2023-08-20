#include<iostream>
using namespace std;
int calculate(int num1,int num2,char op)
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
			cout<<"result is \n"<<result;									
	}
	int main()
	{
		int num1,num2,result;
		char ch='y';
		char op;
		while(ch='y')
		{
	cout<<"Enter 2 numbers";
	cin>>num1>>num2;
	cout<<"enter operator (+,-,*,/)\n)";
	fflush(stdin);
	cin>>op;
	calculate(num1,num2,op);
cout<<"do you want continue,press y\n";
	fflush(stdin);
	cin>>ch;
	}
		return 0;
	}

	
	
