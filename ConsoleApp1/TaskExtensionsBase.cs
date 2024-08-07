﻿namespace ConsoleApp1
{
    public static class TaskExtensionsBase
    {
        public async static void Await(this Task task, 
            Action completedCallback, Action<Exception> errorCallback)
        {
            try
            {
                await task;
                completedCallback?.Invoke();
            }
            catch (Exception ex)
            {
                errorCallback?.Invoke(ex);
            }
        }
    }
}