#include<stdio.h>
void main()
{
	int counter=0;
	char name[20];
	char *ptr;
	printf("Enter name:");
	gets(name);
	ptr=name;
	while(*ptr!=0)
{
{	
    counter=counter+1;
    ptr++;
       }
		printf("length of string is:%d",counter);
	}
}

