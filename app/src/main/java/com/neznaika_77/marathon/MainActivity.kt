package com.neznaika_77.marathon
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*
class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }
    fun raschet(v: View) {
        if (vostpost.length() != 0 && vostpost4.length() != 0) {
            try {
                if (switch1.isChecked) {
                    textView8.text = (vostpost4.text.toString().toDouble() / ((vostpost.text.toString().toDouble() / 100) * (vostpost.text.toString().toDouble() / 100))).toInt().toString()
                    if (textView8.text.toString().toDouble() < 16) {
                        textView10.text = "Острый дефицит массы"
                    }
                    if (textView8.text.toString().toDouble() > 16 && textView8.text.toString().toDouble() < 18.5) {
                        textView10.text = "Недостаточная масса тела"
                    }
                    if (textView8.text.toString().toDouble() > 18.5 && textView8.text.toString().toDouble() < 25) {
                        textView10.text = "Норма"
                    }
                    if (textView8.text.toString().toDouble() > 25 && textView8.text.toString().toDouble() < 30) {
                        textView10.text = "Избыточная масса тела"
                    }
                    if (textView8.text.toString().toDouble() > 30 && textView8.text.toString().toDouble() < 35) {
                        textView10.text = "Ожирение первой степени"
                    }
                    if (textView8.text.toString().toDouble() > 35 && textView8.text.toString().toDouble() < 40) {
                        textView10.text = "Ожирение второй степени"
                    }
                    if (textView8.text.toString().toDouble() > 40) {
                        textView10.text = "Ожирение третьей степени"
                    }
                } else {
                    textView8.text = (vostpost4.text.toString().toDouble() / ((vostpost.text.toString().toDouble() / 100) * (vostpost.text.toString().toDouble() / 100))).toInt().toString()
                    if (textView8.text.toString().toDouble() < 16) {
                        textView10.text = "Острый дефицит массы"
                    }
                    if (textView8.text.toString().toDouble() > 16 && textView8.text.toString().toDouble() < 18.5) {
                        textView10.text = "Недостаточная масса тела"
                    }
                    if (textView8.text.toString().toDouble() > 18.5 && textView8.text.toString().toDouble() < 25) {
                        textView10.text = "Норма"
                    }
                    if (textView8.text.toString().toDouble() > 25 && textView8.text.toString().toDouble() < 30) {
                        textView10.text = "Избыточная масса тела"
                    }
                    if (textView8.text.toString().toDouble() > 30 && textView8.text.toString().toDouble() < 35) {
                        textView10.text = "Ожирение первой степени"
                    }
                    if (textView8.text.toString().toDouble() > 35 && textView8.text.toString().toDouble() < 40) {
                        textView10.text = "Ожирение второй степени"
                    }
                    if (textView8.text.toString().toDouble() > 40) {
                        textView10.text = "Ожирение третьей степени"
                    }
                }
            }
            catch(e:Exception){
                Toast.makeText(baseContext, "Введите корректные значения!", Toast.LENGTH_SHORT)
                        .show()
            }
        }
        else{
            Toast.makeText(baseContext, "Заполните рост и/или вес", Toast.LENGTH_SHORT)
                    .show()
        }
    }
    fun onbmi(v: View){
        val intent = Intent(this,BMR::class.java)
        startActivity(intent)
    }
}