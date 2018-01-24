c) select ename  from dbo.emp where mgr=7567
 g) select job from dbo.emp
 l) select ename from dbo.emp  where ename like ('S%') and ename like ('%S')
 
p) select sum(sal) from dbo.emp

q) select max(sal) from dbo.emp

q) select min(sal) from dbo.emp

q) select avg(sal) from dbo.emp

r)  select max(sal) from dbo.emp where job=Salesman
o)   select count(mgr) from dbo.emp
m) select ename from  dbo.emp where depto not in (30, 40,10)

n) select count(empno) from dbo.emp

a) select ename from dbo.emp where job=Analyst or job=Salesman

b) select * from dbo.emp where hiredate <=1981-09-30

d) select ename from dbo.emp where empno=7369 or empno=7521 or empno=7839 or empno=7934 or empno=7788

f) select ename from dbo.emp where hiredate between 19801-06-30 and 1981-12-31

h) select ename from dbo.emp where job <> commission

j) select  * from dbo.emp where deptno =null

select * from dbo.emp
