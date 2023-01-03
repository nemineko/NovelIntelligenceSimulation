using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public static class UtilsClass
{
    private static Camera mainCamera;
    public static Grid tilemap = BuildingManager.Instance.tilemap;

    public static Vector3 GetMouseWorldPosition()
    {
        if (mainCamera == null) mainCamera = Camera.main;


         Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        Vector3Int tilemapMousePosition = tilemap.WorldToCell(mouseWorldPosition);
        return tilemapMousePosition;
    }
}
