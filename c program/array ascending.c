#include<stdio.h>
void main()
{
int i,j,arr[5],temp;
printf("enter no :");
for(i=0;i<5;i++)
	{	
		scanf("%d",&arr[i]);
			
		}
		for(i=0;i<5;i++)
		{
			for(j=i+1;j<5;j++)
		{
		if(arr[i]>=arr[j])
		{
		temp=arr[i];
		arr[i]=arr[j];
		arr[j]=temp;
	}
}
}
printf("ascending order :");
for(i=0;i<5;i++)
{
	printf("%d",arr[i]);

}
}
