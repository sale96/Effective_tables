namespace EffectiveTables.Application
{
    public class UseCaseExecutor
    {
        public TResult ExecuteQuery<TSearch, TResult>(
            IQuery<TSearch, TResult> query,
            TSearch search)
        {
            return query.Execute(search);
        }

        public void ExecuteCommand<TRequest>(
            ICommand<TRequest> command,
            TRequest request)
        {
            command.Execute(request);
        }
    }
}