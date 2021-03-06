using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Tests.ValidTests
{
	public class XmlValidTest : ValidTest
	{
		public override IClassValidator GetClassValidator(System.Type type)
		{
			return UtilValidatorFactory.GetValidatorForUseExternalTest(type);
		}
	}
}