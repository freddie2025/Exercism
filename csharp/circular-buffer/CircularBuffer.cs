using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
	private Queue<T> _queue;
	private int _capacity;
	
    public CircularBuffer(int capacity)
    {
		_queue = new Queue<T>();
        _capacity = capacity;
    }

    public T Read()
    {
        return _queue.Dequeue();
    }

    public void Write(T value)
    {
        if(_queue.Count == _capacity)
            throw new InvalidOperationException("Reached capacity");
        else
            _queue.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if(_queue.Count == _capacity) _queue.Dequeue();
		Write(value);
    }

    public void Clear()
    {
        _queue.Clear();
    }
}