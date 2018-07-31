using System.Globalization;

namespace Kzari.FinCtrl.Web.Helpers
{
    public class PortugueseCulture : CultureInfo
    {
        public PortugueseCulture() : this("pt-br", true)
        {
        }

        public PortugueseCulture(string cultureName, bool useUserOverride) : base(cultureName, useUserOverride)
        {
            //Your Custom Currency Numbers Calendar Culture Code
        }

        public PortugueseCulture(string name) : base(name)
        {
        }
        public override Calendar Calendar { get; }

        public override Calendar[] OptionalCalendars { get; }
    }
}
