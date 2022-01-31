package com.neznaika_77.marathon
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_bmr.*

class BMR : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_bmr)
    }
    fun onbmr(v: View){
        val intent = Intent(this,MainActivity::class.java)
        startActivity(intent)
    }
    fun raschot(v:View){
        if (vostpost.length() != 0 && vostpost4.length() != 0&&vostpost5.length()!=0) {
            try {
                if (switch1.isChecked) {
                    textView8.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) - 161)).toInt().toString()
                    textView23.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) - 161) * 1.2).toInt().toString()
                    textView24.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) - 161) * 1.375).toInt().toString()
                    textView25.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) - 161) * 1.55).toInt().toString()
                    textView26.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) - 161) * 1.725).toInt().toString()
                    textView27.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) - 161) * 1.9).toInt().toString()
                } else {
                    textView8.text = ((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) + 5).toInt().toString()
                    textView23.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) + 5) * 1.2).toInt().toString()
                    textView24.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) + 5) * 1.375).toInt().toString()
                    textView25.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) + 5) * 1.55).toInt().toString()
                    textView26.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) + 5) * 1.725).toInt().toString()
                    textView27.text = (((10 * vostpost4.text.toString().toDouble()) + (6.25 * vostpost.text.toString().toDouble()) - (5 * vostpost5.text.toString().toDouble()) + 5) * 1.9).toInt().toString()
                }
            }
            catch(e:Exception){
                Toast.makeText(baseContext, "Введите корректные значения!", Toast.LENGTH_SHORT)
                    .show()
            }
        }
        else{
            Toast.makeText(baseContext, "Заполните рост и/или вес и/или возраст", Toast.LENGTH_SHORT)
                .show()
        }
    }
}