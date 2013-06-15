using ServiceStack.ServiceInterface;
using LearningPriorities;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.Text;
using ServiceStack.Redis;
using Funq;


namespace PriorityService
{
	using System;
	using System.Collections;
	using System.Web;
	using System.Web.SessionState;

	public class Global : System.Web.HttpApplication
	{
		protected void Application_Start (Object sender, EventArgs e)
		{
			(new PriorityAppHost()).Init();
		}
	}

	public class PriorityAppHost : AppHostBase
	{
		/// <summary>
		/// Initializes a new instance of your ServiceStack application, with the specified name and assembly containing the services.
		/// </summary>
		public PriorityAppHost() : base("My Learning Priorities", typeof(RedisPriorityService).Assembly) { }

		/// <summary>
		/// Configure the container with the necessary routes for your ServiceStack application.
		/// </summary>
		/// <param name="container">The built-in IoC used with ServiceStack.</param>
		public override void Configure(Container container)
		{
			//Configure ServiceStack Json web services to return idiomatic Json camelCase properties.
			JsConfig.EmitCamelCaseNames = true;

			//Register Redis factory in Funq IoC. The default port for Redis is 6379.
			container.Register<IRedisClientsManager>(new BasicRedisClientManager("localhost:6379"));

			//Register user-defined REST Paths
			Routes
				.Add<LearningItem>("/priorities")
					.Add<LearningItem>("/priorities/{Id}");
		}
	}

	public class RedisPriorityService : Service
	{
		ILearningItemRepository repo = new FakeLearningItemRepository();

		public object Get(LearningItem todo)
		{
			//return repo.GetAll ();
			//Return a single Todo if the id is provided.
			if (todo.Id != default(long))
				return Redis.As<LearningItem>().GetById(todo.Id);

			//Return all Todos items.
			return Redis.As<LearningItem>().GetAll();
		}

		public LearningItem Post(LearningItem item)
		{
			var redis = Redis.As<LearningItem>();

			//Get next id for new todo
			if (item.Id == default(long)) 
				item.Id = redis.GetNextSequence();

			redis.Store(item);

			return item;
		}

	}
}

