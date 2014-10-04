#include <iostream>
#include <cstdlib>
#include <thread>
#include <ctime>

using namespace std;


void fib_helper(long long n);
long long fib(long long n);
void print_funt(void);

int main(void)	{
	int n1 = 47;
	int n2 = 40;
	//create threads
	cout << "allocating threads" << endl;
	thread thread1(fib_helper, n1);
	thread thread2(fib_helper, n2);
	thread thread3(print_funt);
	//join threads.
	cout << "running threads in paralle" << endl;
	thread1.join();
	thread2.join();
	thread3.join();
	cout << "syncing threads" << endl;
	cout << "fuck you " << endl;
	return 0;
}

void print_funt(void) {
	cout << "threaded print statment" << endl;
}

void fib_helper(long long n) {
	long double start = time(0), end;
	long long done = fib(n);
	end = time(0);
	cout << "fib(" << n <<") = " << done << " time s = " << end - start << endl;
}

long long fib(long long n) {
	return (n > 1) ? fib(n-1) + fib(n-2) : 1;
}
