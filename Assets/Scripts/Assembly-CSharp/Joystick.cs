using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
{
	[SerializeField]
	private float handleRange;

	[SerializeField]
	private float deadZone;

	[SerializeField]
	private AxisOptions axisOptions;

	[SerializeField]
	private bool snapX;

	[SerializeField]
	private bool snapY;

	[SerializeField]
	protected RectTransform background;

	[SerializeField]
	private RectTransform handle;

	private RectTransform baseRect;

	protected Canvas canvas;

	protected Camera cam;

	private Vector2 input;

	public float Horizontal => 0f;

	public float Vertical => 0f;

	public Vector2 Direction => default;

	public float HandleRange
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DeadZone
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AxisOptions AxisOptions
	{
		get
		{
			return AxisOptions.Both;
		}
		set
		{
		}
	}

	public bool SnapX
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SnapY
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected virtual void Start()
	{
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	protected virtual void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam)
	{
	}

	private void FormatInput()
	{
	}

	private float SnapFloat(float value, AxisOptions snapAxis)
	{
		return 0f;
	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}

	protected Vector2 ScreenPointToAnchoredPosition(Vector2 screenPosition)
	{
		return default;
	}
}
