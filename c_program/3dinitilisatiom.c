#include<stdio.h>
void main()
{
int arr[3][2];
int row,col;
for(row=0;row<3;row++)
{
	for(col=0;col<3;col++)
	{
		printf("enter number :");
		scanf("%d",&arr[row][col]);
			}
}
for(row=0;row<3;row++)
{
	for(col=0;col<3;col++)
	{
		printf("%d\t",arr[row][col]);
	}
	printf("\n");
}
}
