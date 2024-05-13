﻿using System;
using UnityEngine;

public class SnowTileAim : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private SnowTileController controller;

    private void Awake()
    {
        controller = GetComponent<SnowTileController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
