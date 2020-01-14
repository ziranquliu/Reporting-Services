using Microsoft.ReportingServices.Diagnostics.Utilities;
using System;
using System.Collections;
using System.Security.Permissions;
using System.Web;
using System.Web.Services.Description;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	public sealed class RsSoapExtensionReflector : SoapExtensionReflector
	{
		public override void ReflectMethod()
		{
			//string wsdlServiceLocation = HttpContext.Current.Items["WsdlServiceLocation"] as string;
			//RSTrace.WebServerTracer.Assert(wsdlServiceLocation != null, "serviceLocation != null");
			IEnumerator enumerator = base.ReflectionContext.ServiceDescription.Services.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					IEnumerator enumerator2 = ((Service)enumerator.Current).Ports.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							IEnumerator enumerator3 = ((Port)enumerator2.Current).Extensions.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									SoapAddressBinding soapAddressBinding = ((ServiceDescriptionFormatExtension)enumerator3.Current) as SoapAddressBinding;
									if (soapAddressBinding != null)
									{
										soapAddressBinding.Location = "%ReportServerServiceObjectURL%";
									}
								}
							}
							finally
							{
								IDisposable disposable = enumerator3 as IDisposable;
								if (disposable != null)
								{
									disposable.Dispose();
								}
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator2 as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}
	}
}
