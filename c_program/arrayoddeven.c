#include<stdio.h>
void main()
{
	int i;
	int arr[5];
	for(i=0;i<5;i++)
	{
		printf("enter no :");
		scanf("%d",&arr[i]);
		}
		for(i=0;i<5;i++)
		{
			if(arr[i]%2==0)
			{
				printf("no is even :%d\n",arr[i]);
			}
			else
		{
printf("no is odd :%d\n",arr[i]);
	}
}
}
