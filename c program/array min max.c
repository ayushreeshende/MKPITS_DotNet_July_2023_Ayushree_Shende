#include<stdio.h>
void main()
{
int i,max,min,arr[5];
for(i=0;i<5;i++)
	{	
		printf("enter no :");
		scanf("%d",&arr[i]);
			
		}
		max=arr[0];
		for(i=0;i<5;i++)
		{
			if(arr[i]>max)
		{
		max=arr[i];
	}
}
		printf("\n maximum value:%d",max);
		min=arr[0];
		for(i=0;i<5;i++)
		{
			if(arr[i]<min)
		{
		min=arr[i];
		
	}
	
	}
printf("\n minimum value:%d",min);
}


