using System;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
  public Transform player;
  public float smooothNess = 2f;

  private void Update()
  {
    Vector3 targetPos = new Vector3(player.position.x, player.position.y, -10f);
    transform.position = Vector3.Slerp(transform.position, targetPos, smooothNess * Time.deltaTime);
  }
}
