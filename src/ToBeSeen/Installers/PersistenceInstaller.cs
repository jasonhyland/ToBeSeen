using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ToBeSeen.Plumbing;

namespace ToBeSeen.Installers
{
	public class PersistenceInstaller : IWindsorInstaller
	{
		#region IWindsorInstaller Members

		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.AddFacility<PersistenceFacility>();
		}

		#endregion
	}
}