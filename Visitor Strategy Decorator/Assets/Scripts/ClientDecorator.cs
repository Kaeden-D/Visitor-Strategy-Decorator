using Pattern.Visitor;
using UnityEngine;

namespace Chapter.Decorator
{
    public class ClientDecorator : MonoBehaviour
    {
        private BikeWeapon2 _bikeWeapon;
        private bool _isWeaponDecorated;

        void Start()
        {
            _bikeWeapon = (BikeWeapon2)FindFirstObjectByType(typeof(BikeWeapon2));
        }

        void OnGUI()
        {
            GUILayout.BeginArea(new Rect(500, 0, 200, 500));
            if (!_isWeaponDecorated)
                if (GUILayout.Button("Decorate Weapon"))
                {
                    _bikeWeapon.Decorate();
                    _isWeaponDecorated = !_isWeaponDecorated;
                }

            if (_isWeaponDecorated)
                if (GUILayout.Button("Reset Weapon"))
                {
                    _bikeWeapon.Reset();
                    _isWeaponDecorated = !_isWeaponDecorated;
                }

            if (GUILayout.Button("Toggle Fire"))
                _bikeWeapon.ToggleFire();
            GUILayout.EndArea();
        }
    }
}