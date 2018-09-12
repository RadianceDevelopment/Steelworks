using Terraria.ModLoader;

namespace Steelworks
{
	class Steelworks : Mod
	{
		public Steelworks()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
