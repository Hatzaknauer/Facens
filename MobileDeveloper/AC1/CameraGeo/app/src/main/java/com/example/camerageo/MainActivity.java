package com.example.camerageo;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.location.Location;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    //Define variáveis e suas classes que serão utilizados futuramente
    private ImageView imageViewFoto;
    private Button btnGeo;

    //Relaciona a classe ao XML da classe
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Encontra o botão pelo ID na view e pede permissões para uso de localizações
        btnGeo = (Button) findViewById(R.id.btn_gps);
        ActivityCompat.requestPermissions(this, new String[] {Manifest.permission.ACCESS_FINE_LOCATION}, 123);

        //Define o que o botão vai começar a receber os clicks e o que acontece quando é clickado
        btnGeo.setOnClickListener(new View.OnClickListener() {
            //Quando clickado o botão recebe a localização pelo método GPSTracker
            @Override
            public void onClick(View view) {
                GPStracker g = new GPStracker(getApplication());
                Location l = g.getLocation();
            //Se o resultado anterior não for nulo, alocará latitude e longitude, e depois exibirá.
                if(l != null) {
                    double lat = l.getLatitude();
                    double lon = l.getLongitude();
                    Toast.makeText(getApplicationContext(), "LATITUDE: " + lat +"\n LONGITUDE: " + lon, Toast.LENGTH_LONG).show();
                }
            }
        });

        //Verifica se há permissão para utilizar a câmera, se não tiver, solicita ao usuário
        if(ActivityCompat.checkSelfPermission(this, Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED){
            ActivityCompat.requestPermissions(this, new String[] {Manifest.permission.CAMERA}, 0);
        }

        //Encontra a imagem no xml e a aloca em imageViewFoto
        imageViewFoto = (ImageView) findViewById(R.id.image_foto);
        findViewById(R.id.btn_pic).setOnClickListener(new View.OnClickListener()
        {
            //Quando o botão é clicado o método tirar foto é executado
            @Override
            public void onClick(View view)
            {
                tirarFoto();
            }
        });
    }
    //Método usado para capturar e guardar a foto
    private void tirarFoto() {
        Intent intent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
        startActivityForResult(intent, 1);
    }
    //passa os parâmetros para o método e sobrepõe-se ao método original
    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
    //Gera uma imagem através dos bitmaps e também dados extras recebidos pela câmera
        if(requestCode == 1 && resultCode == RESULT_OK){
            Bundle extras = data.getExtras();
            Bitmap imagem = (Bitmap) extras.get("data");
            imageViewFoto.setImageBitmap(imagem);
        }
        super.onActivityResult(requestCode, resultCode, data);
    }
}