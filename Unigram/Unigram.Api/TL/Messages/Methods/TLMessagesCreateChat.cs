// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.createChat.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesCreateChat : TLObject
	{
		public TLVector<TLInputUserBase> Users { get; set; }
		public String Title { get; set; }

		public TLMessagesCreateChat() { }
		public TLMessagesCreateChat(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesCreateChat; } }

		public override void Read(TLBinaryReader from)
		{
			Users = TLFactory.Read<TLVector<TLInputUserBase>>(from);
			Title = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9CB126E);
			to.WriteObject(Users);
			to.Write(Title);
		}
	}
}