using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ElephantSDK
{
	public class OfferUIManager : MonoBehaviour
	{
		private Canvas _dynamicCanvas;

		private GameObject _uiContainer;

		private static OfferAssetManager _offerAssetManager;

		private string _iapNames;

		private List<PurchaseOption> _currentPurchaseOptions;

		private List<Button> _currentPurchaseButtons;

		private GameObject _loadingPanel;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DisplayOfferUI()
		{
		}

		private void EnablePurchaseButtons()
		{
		}

		private void DismissOfferUI()
		{
		}

		private void CreateBlockingPanel()
		{
		}

		private void IsFullWide()
		{
		}

		private void CreateCanvas()
		{
		}

		private void CreateComponents()
		{
		}

		private void CreateImage(ComponentData component)
		{
		}

		private void SetImage(string url, RawImage rawImage, GameObject imgObject, ComponentData component)
		{
		}

		private void CreateButton(ComponentData component)
		{
		}

		private void SetButtonImage(string url, Image img)
		{
		}

		private void CreateText(ComponentData component)
		{
		}

		private void AdjustFontSizeToFit(Text uiText, RectTransform textRect)
		{
		}

		private string FormatPriceString(string priceDetails, Font font)
		{
			return null;
		}

		private bool HasAllCharacters(Font font, string str)
		{
			return false;
		}

		private TextAnchor TextAlignmentMapper(ComponentData component)
		{
			return TextAnchor.UpperLeft;
		}

		private void SetRectTransform(RectTransform rectTransform, ComponentData component)
		{
		}

		private void SetContainerRectTransform(RectTransform rectTransform, ContainerData container)
		{
		}

		private void PurchaseAction(string componentName)
		{
		}

		private void CloseAction()
		{
		}

		private static Vector2 GetOriginalTopLeft(Vector2 boundingBoxPosition, Vector2 boundingBoxSize, Vector2 originalSize)
		{
			return default;
		}
	}
}
