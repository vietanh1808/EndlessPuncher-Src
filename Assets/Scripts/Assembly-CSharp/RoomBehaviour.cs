using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoomBehaviour : MonoBehaviour
{
	public enum TypeShow
	{
		fall = 0,
		scalePop = 1
	}

	[Serializable]
	public class Rooms
	{
		public GameObject mainRoom;

		public ParticleSystem particleComplete;

		public TypeShow[] show;

		public GameObject[] allRoomObjects;
	}

	[CompilerGenerated]
	private sealed class _003CFallErator_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject obje;

		public RoomBehaviour _003C_003E4__this;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFallErator_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLooknewObje_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomBehaviour _003C_003E4__this;

		public Transform target;

		private Quaternion _003CstrtRot_003E5__2;

		private Quaternion _003CendRot_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLooknewObje_003Ed__18(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CPopErator_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject obje;

		public RoomBehaviour _003C_003E4__this;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPopErator_003Ed__15(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRoomCome_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoomBehaviour _003C_003E4__this;

		public Transform room;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

		private Vector3 _003CstrtPlayer_003E5__4;

		private Vector3 _003CendPlayer_003E5__5;

		private float _003Ct_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRoomCome_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRoomComplete_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform room;

		private Vector3 _003CstartPos_003E5__2;

		private Vector3 _003CendPos_003E5__3;

		private float _003Ct_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRoomComplete_003Ed__12(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public List<Rooms> allRooms;

	public Transform camFollower;

	public Transform player;

	public Animator playerAnim;

	public AnimationCurve fallCurveYPos;

	[Header("Player Settings")]
	public Transform playerAimTarget;

	public void LoadRoomItem(int roomitemLevel)
	{
	}

	public void SectionCompleted()
	{
	}

	public void LookObjeAnim()
	{
	}

	public void LoadRoom()
	{
	}

	[IteratorStateMachine(typeof(_003CRoomCome_003Ed__10))]
	private IEnumerator RoomCome(Transform room)
	{
		return null;
	}

	public void CompleteRoom()
	{
	}

	[IteratorStateMachine(typeof(_003CRoomComplete_003Ed__12))]
	private IEnumerator RoomComplete(Transform room)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFallErator_003Ed__13))]
	private IEnumerator FallErator(GameObject obje)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPopErator_003Ed__15))]
	private IEnumerator PopErator(GameObject obje)
	{
		return null;
	}

	public void SetPlayerLookTheNewObje(Transform targetlook)
	{
	}

	[IteratorStateMachine(typeof(_003CLooknewObje_003Ed__18))]
	private IEnumerator LooknewObje(Transform target)
	{
		return null;
	}
}
