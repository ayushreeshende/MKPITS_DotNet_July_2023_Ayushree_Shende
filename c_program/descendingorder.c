#include<stdio.h>
void main()
{
int i,j,arr[5],temp;
for(i=0;i<5;i++)
	{
		printf("enter number :");
		scanf("%d",&arr[i]);
			
		}
		for(i=0;i<5;i++)
		{
			for(j=i+1;j<5;j++)
		{
		if(arr[i]<=arr[j])
		{
		temp=arr[i];
		arr[i]=arr[j];
		arr[j]=temp;
	}
}
}
printf("descending order:");
for(i=0;i<5;i++)
{
	printf("%d\n",arr[i]);

}
}
