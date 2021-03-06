// <auto-generated/>
using System;

namespace Telegram.Api.TL.Account.Methods
{
	/// <summary>
	/// RCP method account.confirmPhone.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAccountConfirmPhone : TLObject
	{
		public String PhoneCodeHash { get; set; }
		public String PhoneCode { get; set; }

		public TLAccountConfirmPhone() { }
		public TLAccountConfirmPhone(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountConfirmPhone; } }

		public override void Read(TLBinaryReader from)
		{
			PhoneCodeHash = from.ReadString();
			PhoneCode = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5F2178C3);
			to.Write(PhoneCodeHash);
			to.Write(PhoneCode);
		}
	}
}