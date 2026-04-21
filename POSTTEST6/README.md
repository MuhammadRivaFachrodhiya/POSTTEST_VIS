# LINK KE GOOGLE DRIVE:
### https://drive.google.com/drive/folders/1H4fQVb_3b-tb3qGu-L3bNNqDv0ELy8uc?usp=sharing

# Manajemen Panitia pada Event MPL "Mobile Legends Bang Bang
Profesional League"

## Tujuan:
### Tujuan dibuatnya proyek ini agar dapat memenuhi persyaaratan posttest dan dapat melihat point of view dari Event Organizer MPL.

## Fitur:
### Karena terdapat 2 user, berarti fitur nya akan terpisah menjadi 2 sisi, yaitu user 1 dan user 2.
### Admin:
### 1. Untuk login ke akun admin, hanya perlu memasukkan username "MPLID" dan password "Season17".
### 2. Terdapat pula fitur CRUD yang sementara hanya untuk panitia saja.
#### Contoh: Menambahkan panitia melalui admin, mengedit informasi panitia melalui admin, menghapus (simulasi dipecat) oleh admin, dan melihat data-data panitia melalui admin.
### 3. Admin dapat melihat statistik jumlah panitia sesuai divisi nya dan jumlah pelamar yang ingin bekerja di EO ini.
### 4. Admin juga dapat melakukan penerimaan atau penolakan pelamaran kerja melalui dashboard admin. Untuk melakukan penolakan, diperlukan alasan logis agar seorang pelamar dapat melakukan pembenahan diri.

### Tamu/Guest:
### 1. Tamu dapat melakukan pelamaran kerja sesuai bidang/divisi yang ia suka, contoh divisi Talent Manager, Caster, dll.
### 2. Tamu dapat melihat roster dari suatu tim.


## Diharapkan untuk posttest selanjutnya dapat melanjutkan bagian CRUD untuk roster tim yang berada di akun tamu.

# Output Program Guest:
![login.png](Laporan%20Pemvis/login.png)
### Ini adalah tampilan awal ketika program berjalan. Pengguna dapat masuk sebagai tamu maupun sebagai admin dengan ketentuan
### Username: MPLID
### Password: Season17

![landingpage.png](Laporan%20Pemvis/landingpage.png)
### Ini adalah tampilan ketika pengguna masuk sebagai akun tamu. Terdapat beberapa tab yang bisa diklik. Namun, pada tab beranda dan jadwal, untuk sekarang belum ada tampilannya.

![lpTim.png](Laporan%20Pemvis/lpTim.png)
### Ini adalah tampilan jika pengguna menekan tab tim di akun tamu. Terdapat 1 button yang jika ditekan maka akan menampilkan tampilan sebagai berikut:
![tim.png](Laporan%20Pemvis/tim.png)
### Terdapat 9 tim. Sayangnya belum ada fitur CRUD pada tab ini.

![lpKarir.png](Laporan%20Pemvis/lpKarir.png)
### Ini adalah tampilan jika pengguna ingin mendaftar jadi panitia EO MPL ini. Pengguna dapat mengisi nama, nomor hp, email, divisi yang diinginkan, alamat, dan alasan melamar ke EO ini. Contoh:
![isiKarir.png](Laporan%20Pemvis/isiKarir.png)
### Ini adalah contoh pengisian data untuk pelamaran kerja untuk jadi panitia EO ini.
![lpReview.png](Laporan%20Pemvis/lpReview.png)
### Ini adalah tampilan jika pengguna ingin mengisi review untuk panitia EO kami. Pengguna dapat memilih tanggal (Khusus jumat, sabtu, dan minggu), nama (Terdapat nametag pada setiap panitia), nilai (1-5), dan review nya.

# Output Program Admin:
![admin.png](Laporan%20Pemvis/admin.png)
### Ini adalah tampilan awal untuk halaman admin. terdapat beberapa tab yang dapat ditekan. Terdapat juga jumlah panitia aktif, jumlah lamaran menunggu, dan akumulasi panitia sesuai divisinya.
![CRUDmpl.png](Laporan%20Pemvis/CRUDmpl.png)
### Ini adalah tampilan ketika admin ingin menggunakan operator CRUD (Create, Read, Update, dan Delete) dan search. Data yang sekarang ini adalah data dummy.
![lihatLamaran.png](Laporan%20Pemvis/lihatLamaran.png)
### Ini adalah tampilan jika admin ingin membuat aksi terhadap lamaran yang dilakukan oleh pengguna menggunakan akun tamu. Admin dapat memilih nama pelamar, jika ingin diterima maka akan langusng masuk ke daftar panitia. Jika pelamar ditolak, maka diharuskan untuk mengisi alasan kenapa pelamar tersebut ditolak agar pelamar dapat melakukan evaluasi.
![shiftPanitia.png](Laporan%20Pemvis/shiftPanitia.png)
### Tampilan ini digunakan untuk menentukan shift panitia. Pertama, admin harus mengisi tanggal terlebih dahulu. Kedua, admin harus mengisi nama yang ingin ditugaskan. Lalu, tekan tombol tugaskan untuk menugaskan panitia sesuai tanggal.
![evaluasiPanitia.png](Laporan%20Pemvis/evaluasiPanitia.png)
### Tampilan ini digunakan untuk mengevaluasi panitia sesuai dengan review pengguna (Guest/Tamu). Harapannya panitia dapat melakukan improvisasi terhadap kinerja nya agar lebih baik kedepannya.
